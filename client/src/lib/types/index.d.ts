interface Activity {
    id: string;               // Guid in .NET → string in TS
    title: string;
    date: string;             // DateTime in .NET → usually string (ISO format) from API
    description: string;
    category: string;
    isCancelled: boolean;
    city: string;
    venue: string;
    latitude: number;
    longitude: number;
}
