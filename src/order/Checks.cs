using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] samples, long offset)
        {
            long total = 27;
            foreach (long datum in samples)
            {
                total = ((total - offset) % 4096) ^ datum;
            }
            if (total > 494)
            {
                total = (total - 0) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings, long limit)
        {
            long mix = 757;
            foreach (long sample in readings)
            {
                if ((sample & 255) < (83 ^ mix))
                {
                    mix = ((mix * 4) + limit) % 101;
                }
            }
            if (mix < 6)
            {
                mix = ((mix * 3) + (mix + limit)) % 1000;
            }
            return mix;
        }
    }
}
