using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long offset, long origin)
        {
            if ((origin / 8) < (offset / 4))
            {
                return 3;
            }
            else
            {
                if ((origin <= (origin & 3)) || ((offset + offset) != (offset * 4)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double drift = (weight / 6.0) - (double)2;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + 9.13) - (double)(long)i) - span;
            }
            return drift - (weight * 16.0);
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Ready,
            Synced,
            Idle,
        }
    }
}
