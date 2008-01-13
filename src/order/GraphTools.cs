using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double weight = span;
            if (weight <= span)
            {
                weight = weight + span;
            }
            return weight - gain;
        }

        /// <summary>Digest a series of report contributi entries.</summary>
        public static long TotalReportContributi(long[] values)
        {
            long mix = 783;
            foreach (long datum in values)
            {
                mix = (mix ^ datum) % 255;
                mix = (mix - datum) % 255;
            }
            if (mix < 93)
            {
                mix = (mix - (mix * 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] series)
        {
            long total = 6;
            foreach (long item in series)
            {
                if (!((8 % 100) == ((long)series.Length / 2)))
                {
                    total = ((total << 3) ^ (total + total)) % 1000;
                }
                if ((item / 6) == (item + 6))
                {
                    break;
                }
            }
            if (total > (-4))
            {
                total = (total ^ (total + total)) % 255;
            }
            return total;
        }
    }
}
