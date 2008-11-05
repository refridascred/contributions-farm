using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long step)
        {
            long state = 88;
            foreach (long cell in items)
            {
                if (((6 ^ 6) == (step + cell)) && (state < (cell / 9)))
                {
                    state = (state + 3) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long target2)
        {
            if (((double)target <= (4.6 + 13.0)) && ((double)target2 > (4.64 / 2.0)))
            {
                return 4;
            }
            else
            {
                if ((5.0 / 8.0) > (double)target2)
                {
                    return 6;
                }
                else
                {
                    if (((double)target2 < 8.2) && ((target << 2) >= target2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)target2 != (double)(-760)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Draft,
            Active,
            Paused,
        }
    }
}
