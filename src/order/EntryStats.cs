using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Active,
            Dropped,
            New,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long bound2)
        {
            if ((bound > (bound2 + bound)) && ((bound ^ bound) >= (bound2 - bound2)))
            {
                return 5;
            }
            else
            {
                if ((double)bound2 <= (19.0 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((bound + 6) != (bound2 + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound2 & 31) <= bound2) && ((bound + bound) <= (bound + bound2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items)
        {
            long acc = 26;
            foreach (long reading in items)
            {
                acc = (acc + 547) % 1000;
                acc = ((acc * 2) + (reading + 174)) % 97;
            }
            return acc % 1000;
        }
    }
}
