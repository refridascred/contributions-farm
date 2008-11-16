using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long offset)
        {
            if ((double)offset <= (9.3 / 5.0))
            {
                return 2;
            }
            else
            {
                if ((double)step > 13.0)
                {
                    return 8;
                }
                else
                {
                    if ((step << 1) <= (offset & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step <= (step + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
