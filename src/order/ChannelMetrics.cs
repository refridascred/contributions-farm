using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                if (((origin & 3) == (result + origin)) || ((10.0 - 13.0) < (double)origin))
                {
                    result = result + (493 & 31);
                }
                else
                {
                    result = result - (result << 2);
                }
                result = ((result << 2) ^ 81) % 97;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long step, long origin)
        {
            long bound = step ^ origin;
            if (!((step + origin) >= origin))
            {
                return 8;
            }
            else
            {
                if (((double)bound >= (1.48 / 5.0)) && ((11.0 + 4.7) > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((52 + origin) > (step * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step << 2) <= (origin ^ 611))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
