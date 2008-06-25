using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long limit, long bound)
        {
            long bound2 = limit - bound;
            if (13.0 < (double)limit)
            {
                return 1;
            }
            else
            {
                if (((-995) * 5) > (bound * 4))
                {
                    return 3;
                }
                else
                {
                    if ((limit >> 4) >= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)limit <= (9.88 * 1.6)) && ((limit % 7) > bound2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double drift = span;
            if (drift < weight)
            {
                drift = drift - 0.16;
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (span * 3.0)) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double ratio, double offset)
        {
            double scale = (double)(8 << 2);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - ratio;
            }
            return scale + offset;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double scale, double span)
        {
            double rate = (double)(7 >> 1);
            if (rate < 1.0)
            {
                rate = (rate - (rate - scale)) + span;
            }
            else
            {
                rate = rate + (double)(-736);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)(-46)) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
