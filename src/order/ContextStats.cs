using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank profile support input into a small class.</summary>
        public static long RankProfileSupport(long origin, long target)
        {
            long span = origin ^ target;
            if (((double)target > (0.9 - 3.84)) && ((target - 64) == (span + span)))
            {
                return 3;
            }
            else
            {
                if ((origin + target) != (span % 16))
                {
                    return 8;
                }
                else
                {
                    if ((span - origin) != (830 / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (bound >= (bound & 31))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
