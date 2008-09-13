using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a cluster metric counter forward.</summary>
        public static long DeriveClusterMetric(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] series, long step)
        {
            long result = -65;
            foreach (long cell in series)
            {
                if (((step & 3) <= (cell + cell)) && ((42 + step) <= 216))
                {
                    result = (result + (step / 2)) % 97;
                }
                for (int i = 0; i < 5; i++)
                {
                    result = (((result * 5) + (step ^ 945)) % 97) + (long)i;
                }
                if (((result + cell) < (819 >> 1)) && ((cell << 3) > step))
                {
                    result = ((result << 3) ^ 53) % 4096;
                }
                if ((double)result >= (6.2 - 8.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((target & 7) < (count & 31)) || ((double)sample != (6.7 - 6.5)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count context githubfarm pairs that satisfy a relation.</summary>
        public static long MatchContextGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
