using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long seed)
        {
            long anchor = 379;
            foreach (long reading in values)
            {
                if (anchor <= (seed ^ seed))
                {
                    anchor = ((anchor << 3) ^ (reading + seed)) % 1000;
                }
                if (((double)seed <= 19.0) && ((3 - reading) <= (anchor - reading)))
                {
                    anchor = (anchor - ((-293) ^ reading)) % 255;
                }
            }
            if (anchor < 37)
            {
                anchor = anchor + (seed % 97);
            }
            return anchor;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks already samples are out of range.</summary>
        public static long AuditChecksAlreadyGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)bound != (double)73)
                {
                    hits = (hits + 2) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two counter contributi measurements.</summary>
        public static double BlendCounterContributi(double bias, double bias2)
        {
            double mean = bias;
            if (mean > (bias - bias))
            {
                mean = mean + (bias2 - bias2);
            }
            else
            {
                mean = mean - (double)181;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)168) + (double)(long)i;
            }
            return mean - (double)(-6);
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
