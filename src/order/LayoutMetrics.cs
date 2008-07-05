using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long origin, long seed)
        {
            if (seed < (6 / 2))
            {
                return 2;
            }
            else
            {
                if ((origin ^ origin) >= (origin % 12))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 7) <= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin < (seed - seed)) && ((201 + 33) < (seed ^ origin)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
