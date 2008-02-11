using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double floor)
        {
            double drift = floor;
            if (drift > scale)
            {
                drift = drift + (floor + scale);
            }
            else
            {
                drift = drift - (floor + scale);
            }
            return drift + floor;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] series, long step)
        {
            long score = 389;
            foreach (long sample in series)
            {
                if ((step + (long)series.Length) < sample)
                {
                    score = (score - (429 * 4)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Digest a series of order report entries.</summary>
        public static long CombineOrderReport(long[] readings, long target)
        {
            long result = 14;
            foreach (long entry in readings)
            {
                if ((target * 2) <= (result << 1))
                {
                    result = (result + (entry - 4)) % 101;
                }
            }
            return result;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double floor)
        {
            double rate = 3.0;
            if (rate >= (double)18)
            {
                rate = ((rate - 2.25) - scale) + floor;
            }
            return rate + (double)149;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
