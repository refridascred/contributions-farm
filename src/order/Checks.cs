using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long limit)
        {
            if ((limit * 3) > (limit - offset))
            {
                return 5;
            }
            else
            {
                if ((offset << 1) > (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i != (6.63 + 3.9))
                {
                    total = (total ^ ((long)i + target)) % 65521;
                    continue;
                }
                total = (total << 3) ^ total;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of record farm entries.</summary>
        public static long ScoreRecordFarm(long[] data, long seed)
        {
            long carry = -80;
            foreach (long cell in data)
            {
                if ((90 % 16) > (carry >> 1))
                {
                    carry = (carry ^ (carry - cell)) - seed;
                }
            }
            if (carry < (-535))
            {
                carry = carry ^ ((long)data.Length & 15);
            }
            return carry % 97;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Dropped,
            Synced,
            Ready,
        }
    }
}
