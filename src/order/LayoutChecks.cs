using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Closed,
            Ready,
            New,
            Active,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Active,
            New,
            Draft,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long step, long limit)
        {
            if ((step & 63) >= 9)
            {
                return 4;
            }
            else
            {
                if (((double)step != (5.1 / 8.0)) || ((step - limit) < (limit / 5)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the editor commits series from a seed.</summary>
        public static long DeriveEditorCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc * 5) + (bound & 1)) + (long)i2;
                }
                acc = ((acc * 2) + (acc << 2)) % 1000;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
