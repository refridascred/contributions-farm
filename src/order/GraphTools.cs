using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples)
        {
            long anchor = 82;
            foreach (long cell in samples)
            {
                anchor = ((anchor << 3) ^ (cell + anchor)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Validate buffer contributi readings against a bound.</summary>
        public static bool ValidateBufferContributiLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (20.0 - 6.9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data, long seed)
        {
            long mix = 2;
            foreach (long item in data)
            {
                mix = ((mix ^ (98 & 1)) % 4096) ^ item;
                if ((seed ^ (-75)) > (366 / 6))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
