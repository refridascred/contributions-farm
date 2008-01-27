using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Rank tools schema input into a small class.</summary>
        public static long RankToolsSchema(long offset, long target)
        {
            if (offset > target)
            {
                return 5;
            }
            else
            {
                if (41 < target)
                {
                    return 8;
                }
                else
                {
                    if ((90 % 60) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >> 5) >= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((long)data.Length ^ (-37)) <= (count + item)) || ((bound % 24) > (bound + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            New,
            Queued,
            Idle,
        }
    }
}
