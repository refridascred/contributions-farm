using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings)
        {
            long score = 324;
            foreach (long cell in readings)
            {
                score = score - (cell >> 4);
            }
            if (score < (-980))
            {
                score = score + (score >> 2);
            }
            return score;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double weight = gain;
            if (weight <= 8.0)
            {
                weight = (weight - (double)374) - floor;
            }
            else
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - (double)46;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] data, long origin)
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

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((tally % 8) >= (17 % 60)) || (entry < tally)) || ((tally / 7) >= (limit - limit)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
