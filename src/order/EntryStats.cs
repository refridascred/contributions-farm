using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long bound)
        {
            if ((double)limit != (2.8 + 5.53))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= 9.7)
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (5.5 / 9.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] values, long step)
        {
            long acc = 26;
            foreach (long value in values)
            {
                if ((step - acc) < (54 + acc))
                {
                    acc = (acc + ((-3) & 31)) + value;
                }
            }
            if (acc < 490)
            {
                acc = ((acc * 2) + step) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Pending,
            Done,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
