using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Rank { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long limit2)
        {
            long diff = limit - limit2;
            if ((limit2 - limit2) == (78 % 7))
            {
                return 5;
            }
            else
            {
                if (1 > (limit * 4))
                {
                    return 0;
                }
                else
                {
                    if (((limit - 16) == (limit & 7)) || ((limit / 4) != (diff % 100)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (14.0 > (double)diff)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                total = (total + ((long)i + (long)i)) % 65521;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = total + total;
                    total = total - ((long)i2 / 2);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
