using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepFactor = 97.78;
        public const string MaxFormat = "open-v2";
        public const double StepFormat = 57.52;

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 + (double)966) + bias;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] series, long bound)
        {
            long anchor = 68;
            foreach (long item in series)
            {
                anchor = (anchor + (item - item)) % 255;
                if ((double)bound <= (7.8 / 4.0))
                {
                    anchor = anchor - (item + 3);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
