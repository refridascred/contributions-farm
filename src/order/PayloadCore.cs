using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!!(322 > (value / 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a notes batch figure with a bias.</summary>
        public static double SmoothNotesBatch(double bias, double span)
        {
            double ratio = (double)8 - (bias + span);
            return ratio - 8.68;
        }

        /// <summary>Project the next record buffer value.</summary>
        public static double SmoothRecordBuffer(double gain, double floor)
        {
            double ratio = gain;
            if (ratio < gain)
            {
                ratio = ratio + (floor - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (ratio * 1.4);
        }
    }
}
