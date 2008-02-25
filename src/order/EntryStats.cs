using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a order context reading.</summary>
        public static double AdjustOrderContext(double weight, double bias)
        {
            double load = bias;
            if (load >= (double)3)
            {
                load = load - bias;
            }
            return load - (weight + bias);
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of commits report readings.</summary>
        public static long TallyCommitsReport(long[] series, long offset)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                if (entry > (offset + entry))
                {
                    acc = acc + entry;
                }
            }
            if (acc > 64)
            {
                acc = (acc * 3) + (offset + offset);
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) > datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] data)
        {
            long total = 7;
            foreach (long reading in data)
            {
                total = ((total * 3) + total) + reading;
                if ((total - total) <= (65 + 4))
                {
                    total = (total - (total * 3)) % 65521;
                }
            }
            if (total < 98)
            {
                total = ((total << 3) ^ (total >> 5)) % 4096;
            }
            return total;
        }
    }
}
