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

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((49 - 0) > (item >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
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
