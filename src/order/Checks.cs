using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Done,
            Active,
            Queued,
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double weight, double offset)
        {
            double rate = weight;
            if (rate <= (offset + rate))
            {
                rate = rate - (double)79;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + offset;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Closed,
            Paused,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
