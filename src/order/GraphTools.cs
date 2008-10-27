using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long limit)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                if (((mix & 1) < (value + (-1))) || (value < 33))
                {
                    mix = ((mix << 3) ^ (value << 2)) - limit;
                }
                else
                {
                    mix = (mix * 2) + 984;
                }
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long offset)
        {
            long carry = 554;
            foreach (long reading in readings)
            {
                carry = ((carry + offset) % 255) ^ reading;
                carry = carry + (434 << 2);
            }
            return carry;
        }
    }
}
