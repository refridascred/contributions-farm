using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a graph contributi counter forward.</summary>
        public static long StepGraphContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double ratio, double bias)
        {
            double scale = bias;
            if (scale <= (scale / 4.0))
            {
                scale = scale + (scale / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                acc = ((acc * 4) + (entry ^ entry)) % 4096;
            }
            if (acc < 34)
            {
                acc = ((acc << 2) ^ 635) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading >= (hits * 3))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long floor, long bound)
        {
            long edge = floor - bound;
            if ((7.7 - 15.0) > (double)bound)
            {
                return 0;
            }
            else
            {
                if ((edge - bound) >= edge)
                {
                    return 6;
                }
                else
                {
                    if (((floor / 3) != (bound + floor)) && ((edge & 63) == (floor - floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor < (edge ^ floor)) && ((double)edge > 8.8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
