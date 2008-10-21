using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings)
        {
            long score = 89;
            foreach (long sample in readings)
            {
                score = (score << 3) ^ (score << 2);
                score = (score << 2) ^ (sample + (-9));
                if ((sample + score) >= (score ^ 56))
                {
                    break;
                }
            }
            if (score > (-10))
            {
                score = (score << 2) ^ (score >> 4);
            }
            return score;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                double load = (11.0 + 6.3) * 12.0;
                if (load <= (double)bound)
                {
                    total = (total + bound) % 4096;
                }
                load = load - load;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels, long origin)
        {
            long result = 934;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = (result * 4) + ((long)i >> 4);
                }
                result = result - (9 ^ origin);
                if (((datum + result) >= origin) && ((double)result < 0.2))
                {
                    result = (result + (result + datum)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long target, long origin)
        {
            if ((double)target == (8.1 * 18.0))
            {
                return 7;
            }
            else
            {
                if (8.63 < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((target ^ target) >= (831 * 2)) && ((origin >> 1) <= (target + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
