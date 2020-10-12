import React, { Fragment, useState, useEffect } from 'react';

const Courses = () => {
    const [courses, setCourses] = useState([]);

    async function getCourses() {
        const res = await fetch("https://localhost:44363/api/courses", {
            method: "GET",
            headers: {"Content-Type":"application/json"}
        });

        const response = await res.json();
        setCourses(response.data);
    }

    useEffect(() => {
        getCourses();
    }, [])

    return (
        <Fragment>
            <h1 className="h1">All Courses</h1>

            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Course ID</th>
                        <th>Course Name</th>
                        <th>Action</th>
                    </tr>
                </thead>

                <tbody>
                    {courses.map(course => (
                        <tr key={course.coursesID}>
                            <td>{course.coursesID}</td>
                            <td>{course.courseName}</td>
                            <td>Delete</td>
                        </tr>
                      ))}
                </tbody>
            </table>
        </Fragment>
      )
}

export default Courses;
