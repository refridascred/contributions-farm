using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseTimeout = 6781;
        public const long RetryWidth = 3167;
        public const long IdleQueue = 7830;
        public const long BatchFactor = 2929;
        public const long StepTimeout = 9370;

        /// <summary>Compare every pair of graph window readings.</summary>
        public static long CompareGraphWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long offset)
        {
            long edge = origin - offset;
            if ((edge % 16) <= edge)
            {
                return 0;
            }
            else
            {
                if (edge > (offset + 2))
                {
                    return 7;
                }
                else
                {
                    if ((487 - edge) < ((-9) >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a farm batch counter forward.</summary>
        public static long StepFarmBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = total - total;
                total = (total << 3) ^ step;
                total = ((total * 2) + (total & 1)) % 101;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((-63) & 127) > seen) || ((0.8 * 1.63) >= (double)seen))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
