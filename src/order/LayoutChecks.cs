using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next session cluster value from a seed.</summary>
        public static long DeriveSessionCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix << 2) ^ (778 >> 4);
                mix = ((mix << 3) ^ (mix / 4)) % 4096;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Failed,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8954;
        public const double DefaultNotes = 80.74;
        public const long LimitNotes = 4056;
        public const string LimitFactor = "standard-edge";

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long limit)
        {
            if (!(target > (target ^ limit)))
            {
                return 4;
            }
            else
            {
                if ((limit >> 1) != (limit % 100))
                {
                    return 2;
                }
                else
                {
                    if (((limit + target) == (28 + target)) && ((target << 2) < (limit ^ 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
