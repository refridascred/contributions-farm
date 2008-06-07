using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a token editor value against two limits.</summary>
        public static long BucketTokenEditor(long target, long bound)
        {
            long next = target - bound;
            if (((1.8 - 4.4) == (double)target) || (242 >= (bound % 97)))
            {
                return 2;
            }
            else
            {
                if ((next % 10) == (next * 4))
                {
                    return 8;
                }
                else
                {
                    if (((6 >> 1) >= (bound & 127)) || ((target >> 1) <= next))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double floor)
        {
            double gain = scale;
            if (gain < (7.31 * 18.0))
            {
                gain = gain - (scale * 9.88);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain - (floor / 7.0);
        }

        /// <summary>Count checks report pairs that satisfy a relation.</summary>
        public static long OverlapChecksReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark ^ (step << 3)) % 97) + (long)i2;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    mark = ((mark + (step + step)) % 101) - (long)i3;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit checks already readings against a rule.</summary>
        public static long CountChecksAlreadyMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((offset + matches) < sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
