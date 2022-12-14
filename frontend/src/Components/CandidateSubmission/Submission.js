import React from 'react'
import './Submission.css'

function Submission() {
  return (

    <div className='Container'>
      <div>
        <label className="tskname"> Task Name : </label> <p className='para'>name of the task</p>
      </div>
      <div>
        <label className="createby"> Created By : </label> <p className='para'>email of the mentor</p>
      </div>

        <center><h3 className='label-heading'>Upload Task</h3></center>
        <div className="card col-md-6 offset-md-3 offset-md-3">
          <div className="card-body">
            <form>
              <div className="col-lg-12 col-md-6 col-sm-12">
                <div className="form-group">
                  <label className="label-text"> Comment : </label>
                  <textarea name="comment"
                    rows="5" cols="70" className='form-control text-secondary' placeholder='Enter your comment...'>
                  </textarea>
                </div>
              </div>
              <br></br>
              <div className="col-lg-12 col-md-6 col-sm-12">
                <div className="form-group">
                  <label className="label-text"> Upload Link : </label>
                  <input name="Link" className="form-control" placeHolder="Upload github link"/>
                </div>
              </div>
              <center>
                <button className="btn btn-info btn-lg mt-4"><i class="fa fa-check" aria-hidden="true"></i> &nbsp; Upload</button></center>
            </form>
          </div>
        </div>

      
    </div>
  )
}

export default Submission