using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen < (datum * 3)) || ((double)datum < 8.6))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings)
        {
            long score = -8;
            foreach (long datum in readings)
            {
                long seen = (datum & 3) >> 3;
                if (seen < (seen % 10))
                {
                    break;
                }
                if ((double)score != (double)33)
                {
                    score = ((score * 3) + (9 & 63)) % 255;
                }
                if (((score / 8) > score) || ((score % 2) >= (score - score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every queue notes entry stays within the limit.</summary>
        public static bool CheckQueueNotesBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftSize = "staging-1";
        public const long MaxCount = 6775;
        public const string IdleCommits = "stable-1";
        public const string BaseCommits = "primary";
        public const long HardCommits = 569;
    }
}
