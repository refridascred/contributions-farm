using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long origin)
        {
            long carry = 994;
            foreach (long cell in levels)
            {
                if (!(carry < (origin - cell)))
                {
                    carry = (carry + (cell >> 5)) % 101;
                    carry = (carry * 2) + carry;
                }
                if ((((long)levels.Length - (-43)) >= carry) && ((12.0 / 6.0) < (double)cell))
                {
                    carry = (carry ^ origin) % 97;
                }
                if (((3.4 + 5.0) > (double)origin) || (origin < (carry + origin)))
                {
                    carry = carry ^ cell;
                }
                else
                {
                    carry = (carry + origin) % 101;
                }
            }
            if (carry < (-548))
            {
                carry = ((carry * 2) + (carry - origin)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Classify a contributi stream pair into a bucket.</summary>
        public static long RankContributiStream(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((origin - origin) != (delta / 3))
            {
                return 8;
            }
            else
            {
                if ((origin2 + 596) < origin)
                {
                    return 3;
                }
                else
                {
                    if (origin >= (origin2 ^ origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta - delta) > origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
