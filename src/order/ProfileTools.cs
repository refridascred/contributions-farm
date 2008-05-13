using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count window queue pairs that satisfy a relation.</summary>
        public static long MatchWindowQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (5 < (value + (-800)))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long IterateFormatSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc * 5) + (acc * 4);
                acc = ((acc << 2) ^ acc) % 97;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long target)
        {
            long total = 88;
            foreach (long cell in samples)
            {
                total = ((total ^ cell) % 101) + target;
            }
            return total;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!((total - total) < (total * 5)))
                {
                    total = ((total << 3) ^ ((-8) >> 4)) % 4096;
                }
                else
                {
                    total = total + (747 + (long)i);
                }
                total = ((total * 2) + (total + offset)) % 255;
                if (((double)total < (double)offset) || (((long)i * 3) >= ((long)i % 5)))
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
