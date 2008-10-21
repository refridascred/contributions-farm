using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long target, long target2)
        {
            if (target2 > target)
            {
                return 6;
            }
            else
            {
                if ((target2 + target2) < (target2 >> 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)target2 <= 9.92))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double drift = floor;
            if (drift >= (weight / 4.0))
            {
                drift = drift - (weight + drift);
            }
            return drift + floor;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Idle,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Count queue account pairs that satisfy a relation.</summary>
        public static long OverlapQueueAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of commits farm readings.</summary>
        public static long MatchCommitsFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
