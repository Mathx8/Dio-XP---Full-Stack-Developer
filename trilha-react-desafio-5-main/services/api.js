import axios from 'axios';

export const api  = axios.create({
    baseURL: 'https://oadyfiivdbmgyricwxsj.supabase.co/rest/v1',
    headers: {
        apikey: "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im9hZHlmaWl2ZGJtZ3lyaWN3eHNqIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzEyNTE1MDMsImV4cCI6MjA0NjgyNzUwM30.qNZPUw-BxQ0YNFiW6wvog0IjoHKzqQ88Kv3jj8AwwZk",
        authorization: "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im9hZHlmaWl2ZGJtZ3lyaWN3eHNqIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzEyNTE1MDMsImV4cCI6MjA0NjgyNzUwM30.qNZPUw-BxQ0YNFiW6wvog0IjoHKzqQ88Kv3jj8AwwZk"
    }
})