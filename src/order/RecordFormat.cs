using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double weight = (2.84 + rate) - (double)178;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - (weight * 19.0)) + (double)(long)i) + span;
            }
            return weight + (rate * 7.2);
        }

        /// <summary>Audit schema stream readings against a rule.</summary>
        public static long MeasureSchemaStreamGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((3.0 + 18.0) >= (double)matches) || (matches < (reading - matches)))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + target) % 97;
                acc = ((acc * 3) + (36 + acc)) % 97;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
