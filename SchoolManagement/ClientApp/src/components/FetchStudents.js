import React, { Fragment, useEffect, useState } from 'react';

const FetchStudents = () => {
    const [ students, setStudents ] = useState([]);

    async function getStudents() {
        const res = await fetch("https://localhost:44363/api/students", {
            method: "GET",
            headers: {
                "Content-Type": "application/json"
            }
        });
        const response = await res.json();

        setStudents(response.data);
    }

    useEffect(() => {
        getStudents();
    }, [])

    console.log(students);
    return (
        <Fragment>
            <h1 className="h1">All Students</h1>
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Student Name</th>
                        <th>Fees Balance</th>
                        <th>Student Course</th>
                    </tr>
                </thead>

                <tbody>
                    {students.map(student => (
                        <tr key={student.studetName}>
                            <td>{student.studetName}</td>
                            <td>{student.feeBalance}</td>
                            <td>{student.courses.courseName}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </Fragment>
    );
}

export default FetchStudents;