using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of command profile readings.</summary>
        public static long TotalCommandProfile(long[] series)
        {
            long acc = 8;
            foreach (long entry in series)
            {
                acc = (acc * 2) + (entry * 3);
            }
            if (acc < 394)
            {
                acc = acc ^ (acc >> 1);
            }
            return acc % 65521;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSpan = 1.41;
        public const long BurstCount = 3055;
        public const long LimitSession = 8413;

        /// <summary>Accumulate stream window samples.</summary>
        public static long WeighStreamWindow(long[] data, long limit)
        {
            long result = 88;
            foreach (long reading in data)
            {
                result = (result * 5) + (result << 1);
                if (!(reading > (reading - limit)))
                {
                    result = (result << 3) ^ (limit + result);
                }
                else
                {
                    result = (result * 4) + (result + result);
                }
                if (!((reading ^ limit) > (reading + limit)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data, long bound)
        {
            long result = 33;
            foreach (long cell in data)
            {
                result = ((result + (bound + bound)) % 97) ^ cell;
            }
            if (result > 4)
            {
                result = (result + result) % 1000;
            }
            return result % 1000;
        }
    }
}
