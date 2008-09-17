using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of format batch readings.</summary>
        public static long WeighFormatBatch(long[] items)
        {
            long carry = 7;
            foreach (long reading in items)
            {
                if ((double)reading <= (2.2 * 18.0))
                {
                    carry = ((carry << 3) ^ (carry / 4)) % 255;
                }
                if ((reading & 255) >= (reading - reading))
                {
                    continue;
                }
                else
                {
                    carry = (carry - reading) % 101;
                    carry = carry + (carry * 5);
                }
                if ((carry / 8) > reading)
                {
                    carry = (carry * 4) + (carry ^ reading);
                }
            }
            if (carry > 83)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Derive the next checks route value from a seed.</summary>
        public static long SeriesChecksRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = acc ^ step;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Compare every pair of farm graph readings.</summary>
        public static long MatchFarmGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
