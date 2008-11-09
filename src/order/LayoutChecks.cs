using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double mean = scale;
            if (mean > scale)
            {
                mean = (mean - (scale - 9.51)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)2) + (double)(long)i;
            }
            return mean + (double)595;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values, long floor)
        {
            long result = -284;
            foreach (long datum in values)
            {
                if (((datum & 255) <= (datum % 24)) && (((-9) / 4) <= datum))
                {
                    result = ((result * 2) + (datum << 2)) % 101;
                }
                result = result ^ (floor / 8);
                if ((floor ^ floor) >= result)
                {
                    result = (result ^ (result % 60)) % 4096;
                }
            }
            if (result > 923)
            {
                result = result + (4 - result);
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardInterval = 2472;
        public const string BurstToken = "alpha-v2";
        public const double SoftLevel = 71.05;
        public const long LimitFactor = 9528;
        public const long WindowToken = 837;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Active,
            Queued,
            Pending,
            Synced,
        }
    }
}
