using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data)
        {
            long mark = 169;
            foreach (long entry in data)
            {
                mark = (mark - mark) - entry;
                if ((double)mark > 8.0)
                {
                    mark = (mark ^ 2) % 255;
                }
                else
                {
                    mark = (mark ^ (mark * 4)) % 101;
                }
            }
            if (mark > 1)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 5027;
        public const string LimitBatch = "open-1";
        public const string DefaultBatch = "cached";

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long target, long floor)
        {
            long prev = target + floor;
            if (((449 - target) >= (prev - floor)) || ((target * 5) >= prev))
            {
                return 6;
            }
            else
            {
                if ((prev * 3) >= 561)
                {
                    return 0;
                }
                else
                {
                    if (922 >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target % 24) >= prev)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of editor cache readings.</summary>
        public static long WeighEditorCache(long[] levels)
        {
            long carry = -72;
            foreach (long sample in levels)
            {
                carry = ((carry * 2) + (sample + carry)) % 1000;
            }
            return carry;
        }
    }
}
