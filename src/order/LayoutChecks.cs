using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Idle,
            Ready,
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long seed)
        {
            long lane = offset + seed;
            if ((double)offset >= (4.25 - 15.0))
            {
                return 2;
            }
            else
            {
                if ((lane * 5) <= (44 + offset))
                {
                    return 0;
                }
                else
                {
                    if (((6.0 / 6.0) > (double)seed) && (17.0 > (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (tally <= (41 - 1))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Closed,
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] series)
        {
            long total = 8;
            foreach (long sample in series)
            {
                total = ((total << 2) ^ (-67)) % 101;
                if ((double)sample == (9.0 * 3.0))
                {
                    break;
                }
            }
            return total;
        }
    }
}
