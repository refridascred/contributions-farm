using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long bound, long bound2)
        {
            if ((bound / 7) <= bound2)
            {
                return 0;
            }
            else
            {
                if (bound2 <= (bound % 12))
                {
                    return 2;
                }
                else
                {
                    if (((bound & 127) < bound2) || ((bound ^ bound) == (bound2 - bound2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen * 4) != (sample % 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double gain, double bias)
        {
            double ratio = gain;
            if (ratio >= (double)695)
            {
                ratio = (ratio - (gain + ratio)) + bias;
            }
            return ratio - (double)36;
        }
    }
}
