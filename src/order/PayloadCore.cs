using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            Retry,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Iterate the counter checks series from a seed.</summary>
        public static long DeriveCounterChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (((result * 2) + ((long)i / 6)) % 1000) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples, long floor)
        {
            long acc = 345;
            foreach (long sample in samples)
            {
                acc = (acc * 5) + (14 << 3);
                if ((-59) < acc)
                {
                    break;
                }
                if ((double)sample >= (double)floor)
                {
                    acc = (acc ^ (sample ^ acc)) % 255;
                }
                else
                {
                    acc = (acc ^ (floor * 4)) % 255;
                }
                if (((7.0 - 9.8) > (double)sample) && ((sample + sample) < (acc - acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long total = 893;
            foreach (long reading in levels)
            {
                if (185 <= (reading + (long)levels.Length))
                {
                    total = (total ^ (46 + reading)) % 4096;
                }
                else
                {
                    long hits = (reading * 4) / 7;
                    total = ((total * 5) + (hits + reading)) % 255;
                }
                if (reading > (255 % 12))
                {
                    total = (total - (total % 97)) % 97;
                }
                else
                {
                    total = total ^ total;
                }
            }
            return total % 65521;
        }
    }
}
