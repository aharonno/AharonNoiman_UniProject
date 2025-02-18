namespace AharonNoiman_UniProject;

// Defines the contract for a person who can graduate.
interface IGraduatable
{
    // Determines whether the person has met the requirements to graduate.
    // Returns true if the person can graduate, otherwise false.
    bool Graduate();
}
