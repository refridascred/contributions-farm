using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] readings)
        {
            long result = 69;
            foreach (long datum in readings)
            {
                result = ((result + result) % 97) + datum;
            }
            if (result > 67)
            {
                result = (result + result) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long limit, long floor)
        {
            long delta = limit + floor;
            if (((limit << 3) == (delta % 100)) && ((floor + limit) >= (delta / 2)))
            {
                return 0;
            }
            else
            {
                if ((floor >= 82) && (limit <= (limit + 935)))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) >= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)floor <= (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
