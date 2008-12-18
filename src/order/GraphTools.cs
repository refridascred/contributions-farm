using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long bound, long origin)
        {
            long next = bound - origin;
            if ((2.83 - 13.0) > (double)next)
            {
                return 2;
            }
            else
            {
                if ((bound ^ bound) > origin)
                {
                    return 3;
                }
                else
                {
                    if ((next > (next ^ bound)) || ((5 % 100) != (origin % 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series, long step)
        {
            long result = 411;
            foreach (long entry in series)
            {
                if ((65 >> 3) > (result / 2))
                {
                    result = ((result - (-7)) ^ entry) - step;
                }
            }
            return result;
        }

        /// <summary>Roll a format token counter forward.</summary>
        public static long StepFormatToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result << 3) ^ result) ^ (long)i2;
                    result = (result << 3) ^ origin;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first order payload entry that matches the target.</summary>
        public static long LocateOrderPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
