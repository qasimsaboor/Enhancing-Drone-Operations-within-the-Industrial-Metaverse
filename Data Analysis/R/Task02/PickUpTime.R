library(readr)
library(ARTool)
library(ggplot2)
library(dplyr)

# Read the CSV file
df <- read_csv("C:\\Users\\Brian\\Desktop\\Thesis Data\\Test\\Data Long Format\\PickupTime.csv")

df$Angles <- factor(df$Angles)

# Fit the ARTool model
m <- art(PickupTime ~ Angles + (1|PID), data = df)

# Print ANOVA results
anova(m)
art.con(m, "Angles", adjust="bonferroni")

# Calculate means and standard deviations
means <- df %>% 
  group_by(Angles) %>% 
  summarise(mean_pickuptime = mean(PickupTime), sd_pickuptime = sd(PickupTime))

# Ensure the lower bounds of the error bars are not less than zero
means <- means %>%
  mutate(
    ymin = pmax(mean_pickuptime - sd_pickuptime, 0.06),
    ymax = mean_pickuptime + sd_pickuptime
  )

# Plot the data
ggplot(means, aes(x = Angles, y = mean_pickuptime, fill = Angles)) +
  geom_bar(stat = "identity", position = position_dodge(), width = 0.7) +
  geom_errorbar(aes(ymin = ymin, ymax = ymax), width = 0.2, position = position_dodge(0.7)) +
  geom_text(aes(label = round(mean_pickuptime, 1)), vjust = -0.5, position = position_nudge(x = 0.06)) +
  theme_minimal(base_size = 15) +
  theme(panel.border = element_rect(colour = "black", fill=NA, size=1), 
        axis.text = element_text(size = 12, family = "serif"),
        axis.title = element_text(size = 14, family = "serif"),
        plot.title = element_text(size = 16, family = "serif", hjust = 0.5)) +  # Center the title
  labs(y = "Mean Distance (meters)", x = "Angles") +
  ggtitle("Comparison of Distance by Angle of Measurement") +  # Add the title here
  scale_fill_manual(values = c("angle0" = "blue", "angle45" = "darkgreen", "angle90" = "skyblue")) +
  theme(legend.position = "none")

# Save the plot as an image file
ggsave("barplot_with_errorbars_corrected.png", width = 8, height = 6)