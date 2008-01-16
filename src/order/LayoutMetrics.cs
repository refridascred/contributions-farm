using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Rank graph filter input into a small class.</summary>
        public static long GradeGraphFilter(long step, long offset)
        {
            if (((step % 3) == (2 << 1)) && (offset < (offset * 5)))
            {
                return 2;
            }
            else
            {
                if ((double)(-847) > (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((step <= (offset ^ offset)) || ((offset >> 1) >= (step * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step * 4) < (offset % 8)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (acc << 1)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
