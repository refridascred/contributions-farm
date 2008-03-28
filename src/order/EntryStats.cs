using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Size { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((383 - count) < (step - 55))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 1429;
        public const double StepRoute = 25.02;
        public const string LimitInterval = "alpha-1";

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double weight, double span)
        {
            double ratio = span + (0.1 + span);
            return (ratio - (ratio + 10.0)) + weight;
        }
    }
}
