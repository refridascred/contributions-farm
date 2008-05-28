using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate command farm samples.</summary>
        public static long WeighCommandFarm(long[] data, long target)
        {
            long anchor = 40;
            foreach (long sample in data)
            {
                anchor = (anchor + (target * 2)) % 4096;
                if (anchor <= 668)
                {
                    anchor = ((anchor << 3) ^ (32 % 3)) % 255;
                }
                if ((sample & 31) <= (anchor + anchor))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of graph window readings.</summary>
        public static long CompareGraphWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] levels)
        {
            long result = -8;
            foreach (long sample in levels)
            {
                result = (result + (result & 255)) + sample;
                if ((5 >> 5) < (result ^ result))
                {
                    result = (result ^ result) % 101;
                }
            }
            return result;
        }

        /// <summary>Adjust a channel contributi reading.</summary>
        public static double ScaleChannelContributi(double weight, double bias)
        {
            double mean = (double)75 / 7.0;
            if (mean >= weight)
            {
                mean = mean - (6.9 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - (double)0;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((-63) & 127) > seen) || ((0.8 * 1.63) >= (double)seen))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
