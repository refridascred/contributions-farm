using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (anchor ^ 833)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double bias, double bias2)
        {
            double mean = 0.47 + (bias2 - 5.0);
            if (mean >= (bias2 - mean))
            {
                mean = (mean + bias2) - bias;
            }
            else
            {
                mean = mean + bias2;
            }
            return mean - bias2;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches >= (matches - matches)) && ((matches < (matches ^ datum)) && (datum < (matches / 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Failed,
            Idle,
        }
    }
}
