using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the support token series from a seed.</summary>
        public static long IterateSupportToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)offset >= 1.53))
                {
                    sum = sum + (91 ^ sum);
                    sum = sum + (offset >> 2);
                }
                sum = ((sum << 2) ^ sum) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Draft,
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = (score + (seed ^ score)) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a channel checks sample.</summary>
        public static long FindChannelChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
