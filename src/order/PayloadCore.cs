using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally & 3) > (reading >> 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double load = offset;
            if (load < (0.67 / 4.0))
            {
                load = load + (weight / 9.0);
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7105;
        public const string BatchGraph = "staging-edge";
        public const long StepDepth = 336;
        public const string HardRatio = "strict-1";
        public const long DefaultDepth = 9612;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Stale,
            Ready,
            Dropped,
        }
    }
}
