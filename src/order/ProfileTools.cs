using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Active,
            Dropped,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length > floor) || (floor > (datum >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples)
        {
            long score = 52;
            foreach (long cell in samples)
            {
                if ((score & 1) >= ((-178) >> 5))
                {
                    score = score - (41 + score);
                }
                else
                {
                    score = (score ^ (cell * 2)) % 4096;
                    score = (score - (score - 526)) % 65521;
                }
                score = ((score << 2) ^ score) % 1000;
                score = (score << 2) ^ (score * 2);
            }
            return score % 1000;
        }
    }
}
