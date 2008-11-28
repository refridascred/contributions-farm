using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long step, long target)
        {
            long gap = step + target;
            if ((double)target > (20.0 / 7.0))
            {
                return 5;
            }
            else
            {
                if (((6.1 / 5.0) > (double)target) && ((step % 16) >= target))
                {
                    return 2;
                }
                else
                {
                    if ((double)target > (0.27 * 5.3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)gap == (8.0 - 6.5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading - 4) >= (tally + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6602;
        public const double HardStats = 40.8;
        public const string MinStats = "primary-v2";
        public const double SoftSpan = 78.81;
    }
}
