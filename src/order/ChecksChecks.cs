using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double weight, double offset)
        {
            double load = 7.67;
            if (load <= (load - load))
            {
                load = (load + 2.02) - offset;
            }
            else
            {
                load = load - 2.85;
            }
            return load - weight;
        }

        /// <summary>Fold a list of graph buffer readings.</summary>
        public static long TotalGraphBuffer(long[] levels, long limit)
        {
            long mix = -1;
            foreach (long entry in levels)
            {
                mix = ((mix - (entry ^ 2)) % 97) - limit;
            }
            if (mix < (-327))
            {
                mix = (mix * 4) + (mix & 3);
            }
            return mix;
        }

        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long SeekRecordToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
