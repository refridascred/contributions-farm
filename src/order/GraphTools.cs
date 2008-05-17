using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series, long floor)
        {
            long acc = -381;
            foreach (long item in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc ^ 28) % 255) ^ (long)i;
                    acc = (acc - (678 / 9)) % 65521;
                }
                acc = (acc + (floor - item)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of context cache readings.</summary>
        public static long WeighContextCache(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length < 4.8)
                {
                    state = ((state << 2) ^ (sample ^ state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Done,
            Dropped,
            Active,
        }
    }
}
