using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up counter window samples.</summary>
        public static long CompareCounterWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of payload batch entries.</summary>
        public static long TotalPayloadBatch(long[] readings, long seed)
        {
            long carry = 638;
            foreach (long value in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry * 2) + seed) % 1000) - (long)i;
                }
                if (value >= (carry - 976))
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Scale a record token figure with a bias.</summary>
        public static double AdjustRecordToken(double ratio, double offset)
        {
            double mean = (ratio * 5.15) / 3.0;
            if (mean < (double)32)
            {
                mean = (mean + ratio) + offset;
            }
            return mean - mean;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
